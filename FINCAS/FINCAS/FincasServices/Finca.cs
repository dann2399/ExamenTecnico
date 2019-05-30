using FINCAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINCAS.FincasServices
{
    public class FincaServices
    {
        public List<Fincas_Cafeteras> ObtenerDatosFincas()
        {
            var finca1 = new Fincas_Cafeteras()
            {
                Codigo = 1,
                Nombre = "Agua Bonita",
                Cod_Vereda = 1
            };

            var finca2 = new Fincas_Cafeteras()
            {
                Codigo = 2,
                Nombre = "Embrate",
                Cod_Vereda = 2
            };

            var finca3 = new Fincas_Cafeteras()
            {
                Codigo = 3,
                Nombre = "Acer",
                Cod_Vereda = 2
            };

            return new List<Fincas_Cafeteras> { finca1, finca2, finca3 };
        }
        
        public List<Persona_Asociada> ObtenerDatosPersonas()
        {
            var Persona1 = new Persona_Asociada()
            {
                Codigo = 1,
                Nombres = "Andres Fernandez",
                Apellidos = "Perez",
                Parentesco = "Hijo",
                Id_Finca = 1,
                Propietaria = "NO"
            };

            var Persona2 = new Persona_Asociada()
            {
                Codigo = 2,
                Nombres = "Fernando",
                Apellidos = "Perez",
                Parentesco = "Papa",
                Id_Finca = 1,
                Propietaria = "SI"
            };

            var Persona3 = new Persona_Asociada()
            {
                Codigo = 3,
                Nombres = "Fabio ",
                Apellidos = "Herrera",
                Parentesco = "esposo",
                Id_Finca = 2,
                Propietaria = "NO"
            };

            var Persona4 = new Persona_Asociada()
            {
                Codigo = 4,
                Nombres = "Gloria",
                Apellidos = "Tabares",
                Parentesco = "esposa",
                Id_Finca = 2,
                Propietaria = "SI"
            };

            var Persona5 = new Persona_Asociada()
            {
                Codigo = 5,
                Nombres = "Daniel",
                Apellidos = "Herrera Tabares",
                Parentesco = "hijo",
                Id_Finca = 2,
                Propietaria = "NO"
            };

            return new List<Persona_Asociada> { Persona1, Persona2, Persona3, Persona4, Persona5 };
        }

        public List<Empleados> ObtenerDatosTrabajadores()
        {
            var Empleado1 = new Empleados()
            {
                Codigo = 1,
                Nombres = "Santiago",
                Apellidos = "Moreno",
                Cod_Finca = 1
            };

            var Empleado2 = new Empleados()
            {
                Codigo = 2,
                Nombres = "Maria",
                Apellidos = "lopez",
                Cod_Finca = 1
            };

            var Empleado3 = new Empleados()
            {
                Codigo = 3,
                Nombres = "Jorge",
                Apellidos = "jimenez",
                Cod_Finca = 2
            };

            var Empleado4 = new Empleados()
            {
                Codigo = 4,
                Nombres = "vanessa",
                Apellidos = "hernandez",
                Cod_Finca = 2
            };



            return new List<Empleados> { Empleado1, Empleado2, Empleado3, Empleado4};
        }

        public List<Vereda> ObtenerDatosVereda()
        {
            var Vereda1 = new Vereda()
            {
                Codigo = 1,
                Nombre = "Vereda la uno",
                IdMunicipio = 1
            };

            var Vereda2 = new Vereda()
            {
                Codigo = 2,
                Nombre = "Vereda la dos",
                IdMunicipio = 1
            };

            var Vereda3 = new Vereda()
            {
                Codigo = 3,
                Nombre = "Vereda la tres",
                IdMunicipio = 2
            };

            var Vereda4 = new Vereda()
            {
                Codigo = 4,
                Nombre = "Vereda la cuatro",
                IdMunicipio = 2
            };


            return new List<Vereda> { Vereda1, Vereda2, Vereda3, Vereda4 };
        }

        public List<Municipio> ObtenerDatosMunicipio()
        {
            var Muni1 = new Municipio()
            {
                Codigo = 1,
                Nombre = "Manizales",
                Cod_Depart = 1
            };

            var Muni2 = new Municipio()
            {
                Codigo = 2,
                Nombre = "Villamaria",
                Cod_Depart = 1
            };
            


            return new List<Municipio> { Muni1, Muni2};
        }

        public List<Departamento> ObtenerDatosDepart()
        {
            var Dep1 = new Departamento()
            {
                Codigo = 1,
                Nombre = "Caldas"
            };
            
            return new List<Departamento> { Dep1 };
        }

    }
}
