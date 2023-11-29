/*
 *Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor:Luis Ferreira
 * */

using System.Collections.Generic;

namespace Persons
{
    public class Enfermeiros
    {
        private List<Enfermeiro> enfermeirosList; // Utilizando List<Enfermeiro> em vez de Enfermeiro[]

        public Enfermeiros()
        {
            enfermeirosList = new List<Enfermeiro>(); // Inicializando a lista vazia
        }

        public List<Enfermeiro> EnfermeirosList
        {
            get { return enfermeirosList; }
        }

        public bool AdicionarEnfermeiro(Enfermeiro enfermeiro)
        {
            enfermeirosList.Add(enfermeiro); // Adicionando o enfermeiro à lista
            return true; // Não há mais limite, então sempre pode adicionar
        }

        public bool RemoverEnfermeiro(int codigoEnfermeiro)
        {
            Enfermeiro enfermeiroParaRemover = enfermeirosList.Find(e => e.CodigoEnfermeiro == codigoEnfermeiro);
            if (enfermeiroParaRemover != null)
            {
                enfermeirosList.Remove(enfermeiroParaRemover); // Removendo o enfermeiro da lista
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Enfermeiro> ListarEnfermeiros()
        {
            return new List<Enfermeiro>(enfermeirosList); // Retorna uma nova lista com os enfermeiros
        }

        public int ContarEnfermeiros()
        {
            return enfermeirosList.Count; // Contando o número de enfermeiros na lista
        }
    }
}
