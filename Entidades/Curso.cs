using System;

namespace  CoreEscuela.Entidades {
    public class Curso {

        public string UniqueId {get; private set;}
        public string Nombre {get;set;}
        public TiposJornada Jornada {get; set;}

        public Curso (string name, TiposJornada tipoEscuela){
            this.Nombre = name;
            this.UniqueId = Guid.NewGuid().ToString();
            this.Jornada = tipoEscuela;
        }
        public override string ToString()
        {
            return $"{Nombre} jornada de escuela: {Jornada} ID: {UniqueId}";
        }

    }
}