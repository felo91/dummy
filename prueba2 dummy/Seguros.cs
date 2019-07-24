using System;

namespace prueba2_dummy
{
    class Seguros
    {
        // defino atributos de los Gerentes
        public String area = "";
        public int costoProximo = 0;
        public int cobertura = 0;
        public int nivel = 0;
        public int franquicia = 0;

        public Seguros() {
            area = "";
            costoProximo = 0;
            cobertura = 0;
            franquicia = 0;
            nivel = 0;
        }

        public Seguros(String a)
        {
            area = a;
            //costos coberturas y nivel tienen que ir a buscar cuales
            //son sus valores en la bd
            costoProximo = 0;
            cobertura = 0;
            franquicia = 0;
            nivel = 0;
        }

        public void aumentarNivel() {
            nivel +=  1;
            //Actualizar BDJugador
        }
        
    }
}
