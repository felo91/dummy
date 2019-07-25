﻿using System;

namespace prueba2_dummy
{
    class Seguros
    {
        // defino atributos de los Gerentes
        public String area = "";
        public int[] costoProximo = new int [5];
        public int[] cobertura = new int [5];
        public int nivel = 0;
        public int[] franquicia = new int[5];

        public Seguros() {
            area = "";
            for (int i = 0; i < 5; i++)
            {
                costoProximo[i] = 0;
                cobertura[i] = 0;
                franquicia[i] = 0;
            }
            nivel = 0;
        }

        public Seguros(String a)
        {
            area = a;
            //costos coberturas y nivel tienen que ir a buscar cuales
            //son sus valores en la bd
            for (int i = 0; i < 5; i++)
            {
                costoProximo[i] = 0;
                cobertura[i] = 0;
                franquicia[i] = 0;
            }
            nivel = 0;
        }

        public void aumentarNivel() {
            nivel +=  1;
            //Actualizar BDJugador
        }
        
    }
}
