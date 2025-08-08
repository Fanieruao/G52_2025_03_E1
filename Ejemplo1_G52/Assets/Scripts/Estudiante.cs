using UnityEngine;
using System;

namespace packagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {

        public string codeE;
        public string namcarreraE;

        public Estudiante()
        {
        }

        public Estudiante(string codeE, string namcarreraE, string nameP, string mailP, string dirP)
            : base(nameP, mailP, dirP)
        {
            this.codeE = codeE;
            this.namcarreraE = namcarreraE;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string NamcarreraE { get => namcarreraE; set => namcarreraE = value; }
    }

}