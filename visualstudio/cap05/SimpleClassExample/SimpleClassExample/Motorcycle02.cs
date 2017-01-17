using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Construtor Padrao revisado
/// Palavra Chave this
/// Nao podemos usar this em membros statics
/// Construtores encadeados
/// 
/// </summary>
namespace SimpleClassExample
{
    class Motorcycle02
    {
        public int driverIntensity;

        public string name;

        public string driverName;

        /// <summary>
        /// Construtor com argumentos opcionais
        /// </summary>
        /// <param name="intensity"></param>
        /// <param name="name"></param>
        /// <param name=""></param>
        public Motorcycle02(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaaeeeewwww");
            }

        }

        public void setDriverName(string name)
        {
            // atribui a variavel name para si mesma
            // quando chamado retorna vazio
            // name = name;
            
            //nao necessario que a variavel de escopo global e diferente da local
            driverName = name;

            // usando a palavra chave this para eleminar ambiguidades de escopo da classe
            // variaveis com mesmo nome 
            // refere-se aos parametros da propria classe
            this.name = name;
        }
        
    }
}
