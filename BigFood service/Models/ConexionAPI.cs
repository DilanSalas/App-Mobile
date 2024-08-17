using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace BigFood_service.Models
{
    public class ConexionAPI
    {
        public HttpClient Iniciar()
        {
            var client = new HttpClient();

            //Se indica la direccion donde esta ubicada la API
            client.BaseAddress = new Uri("http://APIProyecto1.somee.com"); 

            return client;
        }
    }
}
