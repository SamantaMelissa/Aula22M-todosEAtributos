namespace Aula22MetodosEatributosEstáticos
{
    public static class Conversor
    {
        //O "static" serve para resolver problemas específicos!!!

        //Atributos
        public static float CotacaoDolar =  5.23f;
        public static float CotacaoEuro =  5.90f;


        //Métodos
        public static float ConverterRealParaDolar( float valor){
            return valor * CotacaoDolar;
        }
        public static float ConverterDolarParaReal( float valor){
            return valor/CotacaoDolar;
        }

        public static float ConverterRealParaEuro( float valor){
            return valor * CotacaoEuro;
        }
        public static float ConverterEuroParaReal( float valor){
            return valor/CotacaoEuro;
        }
    }
 }
