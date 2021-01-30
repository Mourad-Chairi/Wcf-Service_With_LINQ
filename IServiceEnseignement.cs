using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEnseignement
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IServiceEnseignement" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceEnseignement
    {
        [OperationContract]
        List<Eleve> getByCNE(string s);
    }
}
