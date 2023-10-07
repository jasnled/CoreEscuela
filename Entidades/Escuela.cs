namespace CoreEscuela.Entidades {

    public class Escuela
    {
        string name;
        public string Name {
            get{ return name; }
            set{ name=value.ToUpper(); }
        }

        public int AñoDeCreación {get;set;}
         
        public string Pais {get;set;}

        public string Ciudad {get; set;}

        public TiposEscuela TipoEscuela {get;set;}
        //public Escuela (string nam, int age) => (Name, AñoDeCreación) = (nam, age);

        public Escuela (string nam, int age, TiposEscuela tipo, string pais="", 
        string ciudad=""){
            this.Name = nam;
            this.AñoDeCreación = age;
            this.TipoEscuela = tipo;
            this.Pais = pais;
            this.Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: \"{this.name}\", tipo: {this.TipoEscuela}\nPaís: {this.Pais} Ciudad: {this.Ciudad}";
        }
    } 
}