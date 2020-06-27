using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombres { get; set;}
        public string Apellidos { get; set;}
        public string NombresCompletos { get; set;}
    }
}