﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceEnseignement" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ServiceEnseignement.svc ou ServiceEnseignement.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceEnseignement : IServiceEnseignement
    {
        DataClassesEnseignementDataContext eleves = new DataClassesEnseignementDataContext();

        public List<Eleve> getByCNE(string s)
        {
            return (from p in eleves.Eleve where p.CNE == s select p).ToList();
        }
    }
}
