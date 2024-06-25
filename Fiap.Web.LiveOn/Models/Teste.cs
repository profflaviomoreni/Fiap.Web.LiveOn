using System.Collections.ObjectModel;

namespace Fiap.Web.LiveOn.Models
{
    public class Teste
    {

        public IList<Montadora> GetData()
        {
            var colletion = new LinkedList<Montadora>();

            return new List<Montadora>(colletion);
        }


    }
}
