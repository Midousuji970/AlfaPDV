using AlfaPdv.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfaPdv.Services
{
    internal class FunServices
    {

        public async Task<ChamarFun> Integracao(int id)
        {
            HttpClient httpClient = new HttpClient();
            var resposta = await httpClient.GetAsync($"http://localhost/Portfolio/login.php?tabela=funcionario&id={id}");
            var jsonString = await resposta.Content.ReadAsStringAsync();

            ChamarFun jason = JsonConvert.DeserializeObject<ChamarFun>(jsonString);

            return jason;

        }

        public async Task <List<VerFun>> Integra(){ 
        HttpClient httpClient = new HttpClient();
        var ver = await httpClient.GetAsync($"http://localhost/Portfolio/teste.php?tabela=funcionario");
        var jsonFun = await ver.Content.ReadAsStringAsync();

        List<VerFun> fila = JsonConvert.DeserializeObject<List<VerFun>>(jsonFun);
        return fila;

        }

    }
}
