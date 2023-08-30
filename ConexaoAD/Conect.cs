using System.DirectoryServices;

namespace ConexaoAD {
    public class Conect {
        public static bool AuthenticateUser(string NomeDeDominio, string NomeDeUsuario, string Senha) {
            bool ret = false;

            try {
                DirectoryEntry diretorio = new DirectoryEntry("LDAP://" + NomeDeDominio, NomeDeUsuario, Senha);
                DirectorySearcher dsearch = new DirectorySearcher(diretorio);
                SearchResult results = null;

                results = dsearch.FindOne();

                ret = true;
            }
            catch {
                ret = false;
            }

            return ret;
        }
    }
}
