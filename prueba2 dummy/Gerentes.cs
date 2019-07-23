using System;

namespace prueba2_dummy
{
    class Gerentes
    {
        // defino atributos de los Gerentes
        String area;
        int costoProximo;
        int cobertura;
        int nivel;


        public Gerentes() {
            area = "";
            costoProximo = 0;
            cobertura = 0;
            nivel = 0;
        }

        public Gerentes(String a)
        {
            area = a;
            //costos coberturas y nivel tienen que ir a buscar cuales
            //son sus valores en la bd
            costoProximo = 0;
            cobertura = 0;
            nivel = 0;
        }

        public void aumentarNivel() {

            nivel = nivel + 1;
            //Actualizar BDJugador
        }
        
    }
}
