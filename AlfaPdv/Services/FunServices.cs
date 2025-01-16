using AlfaPdv.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace AlfaPdv.Services
{
    internal class FunServices
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public string connectionString = "Server=127.0.0.1;Port=3306;Database=alfapdv;User ID=alfamaq;Password=29814608;SslMode=None;";
        public async Task<VerFun>Integracao(int id,string senha)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT funId, funSenha FROM funcionario WHERE funId = @id AND funSenha = @senha", conn))
                {
                    await conn.OpenAsync();
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (reader.Read())
                        {
                            VerFun verfun = new VerFun {
                                Id = Convert.ToInt32(reader["funId"]),
                                Senha = reader["funSenha"] != DBNull.Value ? reader["funSenha"].ToString() : null
                            };
                            await conn.CloseAsync();
                            return verfun;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public async Task<DataTable> Integra()
        {
            
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (MySqlCommand command = new MySqlCommand("SELECT funId, funNome, funCargo FROM funcionario", connection))
                {
                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;

        }

        //public async Task<FunCompleto> FunFullAdicio() {
        //    string connectionString = "Server=127.0.0.1;Port=3306;Database=alfapdv;User ID=alfamaq;Password=29814608;SslMode=None;";
        //    using (MySqlConnection connection = new MySqlConnection(connectionString)) {
        //        await connection.OpenAsync();
        //        using(MySqlCommand comando = new MySqlCommand("INSERT INTO funcionario (funId,funNome,funCpf,funSenha,funEnd,funEndNum,funTele,funCargo,funMail,funDataEnt,funDataSai,funAtive) " +
        //            "values (@id, @nome, @cpf, @senha, @endereco, @numero, @telefone, @cargo, @email, @dataEn, @dataSai, @atividade)"))
        //        {

        //        }
            
        //    }
        //}
        public async Task<FunCompleto> FunFullIntegra(int id) // esse comando puxa todas as infos
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=alfapdv;User ID=alfamaq;Password=29814608;SslMode=None;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (MySqlCommand command = new
             MySqlCommand("SELECT * FROM funcionario WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                    {
                        if (reader.Read())

                        {
                            FunCompleto full = new FunCompleto
                            {
                                // Mapeie os campos do banco para as propriedades do objeto
                                funId = Convert.ToInt32(reader["funId"]),
                                funNome = reader["funNome"] != DBNull.Value ? reader["funNome"].ToString() : null,
                                funCpf = reader["funCpf"] != DBNull.Value ? reader["funCpf"].ToString() : null,
                                funSenha = reader["funSenha"] != DBNull.Value ? reader["funSenha"].ToString() : null,
                                funEnd = reader["funEnd"] != DBNull.Value ? reader["funEnd"].ToString() : null,
                                funEndNum = reader["funEndNum"] != DBNull.Value ? Convert.ToInt32(reader["funEndNum"]) : 0,
                                funCargo = reader["funCargo"] != DBNull.Value ? Convert.ToInt32(reader["funCargo"]) : 0,
                                funTele = reader["funTele"] != DBNull.Value ? Convert.ToInt32(reader["funTele"]) : 0,
                                funMail = reader["funMail"] != DBNull.Value ? reader["funMail"].ToString() : null,
                                funDataEnt = reader["funDataEnt"] != DBNull.Value ? Convert.ToInt32(reader["funDataEnt"]) : 0,
                                funDataSai = reader["funDataSai"] != DBNull.Value ? Convert.ToInt32(reader["funDataSai"]) : 0,
                                funAtive = reader["funAtive"] != DBNull.Value ? Convert.ToChar(reader["funAtive"]) : 'N'
                            };

                            return full;
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

        public async Task<HttpResponseMessage> Puts(HttpRequestMessage request)
        {
            try
            {
                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro na atualização: {response.StatusCode}, Detalhes: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fazer a solicitação PUT: " + ex.Message, ex);
            }
        }
        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            try
            {
                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return response;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro na criação: {response.StatusCode}, Detalhes: {errorContent}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fazer a solicitação POST: " + ex.Message, ex);
            }
        }
        public async Task Remover(int id, string nome)
        {
            var jsonBody = $"{{\n\t\"id\": \"{id}\",\n\t\"nome\": \"{nome}\"\n}}";

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://localhost/Portfolio/funcionario.php"),
                Headers =
            {
                { "User-Agent", "insomnia/8.6.1" },
            },
                Content = new StringContent(jsonBody)
                {
                    Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
                }
            };

            try
            {
                using (var response = await httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                     // Você pode remover essa linha se não precisar do corpo da resposta
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Erro ao fazer a solicitação DELETE: " + ex.Message, ex);
            }
        }
    //    private void A(int id) {
      //      string database = "Server=localhost;Database=ALFAPDV;User ID=alfamaq;Password=29814608";
      //
        //    using (MySqlConnection conn = new MySqlConnection(database))
          //  {
            //    try { 
              //      conn.Open();
                //    MySqlCommand cmd = new MySqlCommand("SELECT * FROM FUNCIONARIO", conn);
                  //  MySqlDataReader reader = cmd.ExecuteReader();
//
  //              }
    //            catch
      //          {
      
      //          }
                

        //    } 
      //  }


    }   
        
}
