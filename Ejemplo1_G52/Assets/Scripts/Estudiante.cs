using UnityEngine;
using System;

namespace packagePersona
{

    public class Estudiante : Persona
    {

        private string codeE;
        private string namcarreraE;

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