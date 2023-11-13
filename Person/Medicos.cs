/*
 * Gonçalo Cardoso Ferreira da Costa 
 * a26024@alunos.ipca.pt
 * POO
 * LESI
 * Professor: Luis Ferreira
 */

using System;

namespace Person
{
    public class Medicos
    {
        private Medico[] medicosArray;
        private const int MAX_MEDICOS = 2;
        private int totalMedicos;

        public Medicos()
        {
            medicosArray = new Medico[MAX_MEDICOS];
            totalMedicos = 0;
        }

        public static int MaxMedicos { get { return MAX_MEDICOS; } }

        public Medico[] MedicosArray
        {
            get { return (Medico[])medicosArray.Clone(); }
            
        }

        public int TotalMedicos
        {
            get { return totalMedicos; }
        }

        public void AdicionarMedico(Medico medico)
        {
            if (totalMedicos < MAX_MEDICOS)
            {
                medicosArray[totalMedicos] = medico;
                totalMedicos++;
            }
            else
            {
                Console.WriteLine("O limite máximo de médicos foi atingido. Não é possível adicionar mais médicos.");
            }
        }

        public void RemoverMedico(int codigoMedico)
        {
            for (int i = 0; i < totalMedicos; i++)
            {
                if (medicosArray[i].CodigoMedico == codigoMedico)
                {
                    for (int j = i; j < totalMedicos - 1; j++)
                    {
                        medicosArray[j] = medicosArray[j + 1];
                    }
                    medicosArray[totalMedicos - 1] = null;
                    totalMedicos--;
                    return;
                }
            }
        }

        public int ContarMedicos()
        {
            return totalMedicos;
        }
    }
}

