using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Back_CRUDs_BD
{
    public abstract class CRUDs_BD
    {
        protected string connectionString;
        private DBMS dbms;
        protected string tabla;
        protected List<string> campos = new List<string>();
        protected List<string> valores = new List<string>();

        //vars para el ConnectionString
        protected string host;
        protected string us;
        protected string pwd;
        protected string puerto;
        protected string nombreBD;


        /// <summary>
        /// Con esta variable se definen los criterios de búsqueda que se aplicarán en un SELECT en el WHERE. "SELECT * FROM usuarios WHERE email=a22311151@uthermosillo".
        /// </summary>
        protected string criteriosBusqueda;
        /// <summary>
        /// Ayuda a establecer el ORDER BY; GROUP BY o LIMIT para personalizar la búsqueda.
        /// </summary>
        protected string ordenGruposLimit;
        public string msgError;

        public object dr;

        //--METODOS--//
        public abstract bool insertar(string tabla, List<string> campos, List<ValoresAInsertar> valores);
        public abstract bool modificar(string tabla, List<string> campos, List<ValoresAInsertar>valores, int id);
        public abstract bool borrar(string tabla, int id);
        public abstract List<object[]> consulta(string tabla);
        public abstract List<object[]> consulta(string tabla, string criterioBusqueda);
    }
}