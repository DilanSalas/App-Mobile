using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFood_service.Models
{ 
    public class Conexion
    {
        //Para interactuar con la api nuestra 
        private readonly ConexionAPI conexionAPI;
        private readonly HttpClient client;
        public Conexion()
        {
            conexionAPI = new ConexionAPI();
            client = conexionAPI.Iniciar();
        }
        public async Task<List<Producto>> ObtenerProductos()
        {
            List<Producto> productList = null;

            try
            {
                var response = await client.GetAsync("Producto/Listado");

                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                   productList = JsonConvert.DeserializeObject<List<Producto>>(data);
                }
                else
                {
                    // Manejar respuesta no exitosa
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return productList;
        }
        public async Task<Usuario> ValidarUsuario(string pUsuario, string pPassword)
        {
            try
            {
                // Configurar la URL con los parámetros
                var requestUrl = $"/Usuario/ValidarUsuario?pUsuario={pUsuario}&pPassword={pPassword}";

                // Hacer la solicitud GET
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Deserializar la respuesta JSON en un objeto Usuario
                    Usuario user = JsonConvert.DeserializeObject<Usuario>(responseBody);
                    return user;
                }
                else
                {
                    Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción: {ex.Message}");
                return null;
            }
        }

    }
}
