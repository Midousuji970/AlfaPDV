using AlfaPdv.Classes;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.Http;
using System.Threading.Tasks;

namespace AlfaPdv.Services
{
    internal class ProdServices
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task<VerProd> BuscarProduto3(int id)
        {
            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/produto.php?id={id}");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            // A resposta é um array JSON, precisamos desserializar para uma lista
            List<VerProd> produtos = JsonConvert.DeserializeObject<List<VerProd>>(jsonString);

            // Retornamos o primeiro item da lista, assumindo que o filtro de ID na API funciona corretamente
            return produtos?.FirstOrDefault();
        }
        public async Task<VerProd> BuscarProduto(int id)
        {
            conexao conf = new conexao();
            string conecta = conf.ConexaoBD;

            using (MySqlConnection con = new MySqlConnection(conecta))
            {
                await con.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand("SELECT prodid, proddescri, prodpre FROM produto WHERE prodid = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            VerProd verProd = new VerProd
                            {
                                Id = Convert.ToInt32(reader["prodid"]),
                                Nome = reader["proddescri"]?.ToString(),
                                Preco = reader["prodpre"] != DBNull.Value ? Convert.ToSingle(reader["prodpre"]).ToString("F2") : null
                            };

                            return verProd;
                        }
                        else
                        {
                            // Nenhum registro encontrado
                            return null;
                        }
                    }
                }
            }
        }


        public async Task<List<VerProd>> Produ()
        {
            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/produto.php");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            List<VerProd> produtos = JsonConvert.DeserializeObject<List<VerProd>>(jsonString);
            return produtos;
        }
    }
}
