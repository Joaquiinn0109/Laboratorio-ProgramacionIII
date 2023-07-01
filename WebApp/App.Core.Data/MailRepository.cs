using App.Core.Entities;

namespace App.Core.Data
{
    public class MailRepository
    {
        public int Contador;
        public MailRepository() { }
        public List<Mail> Search(string textToSearch,
                                 int pageSize,
                                 int pageIndex)
        {
            var skipRows = (pageIndex - 1) * pageSize;
            using (var context = new MailsContext())
            {
                var query = from m in context.Mails
                            where m.Asunto.Contains(textToSearch)
                            select m;

                var contar = query.Count();

                return query.Skip(skipRows)
                            .Take(pageSize)
                            .ToList();
            }
        }
    }
}