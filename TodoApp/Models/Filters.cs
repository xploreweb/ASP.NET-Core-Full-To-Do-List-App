namespace TodoApp.Models
{
    public class Filters
    {
        public Filters(string filterstring) {
            FilterString = filterstring ?? "kõik-kõik-kõik";
            string[] filters = FilterString.Split('-');
            CategoryID = filters[0];
            Due = filters[1];
            StatusID = filters[2];
        }
        
        public string FilterString { get; }
        public string CategoryID { get; }
        public string Due {  get; }
        public string StatusID { get; }

        public bool HasCategory => CategoryID.ToLower() != "kõik";
        public bool HasDue => Due.ToLower() != "kõik";
        public bool HasStatus => StatusID.ToLower() != "kõik";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string> {
                { "tulevikus", "Tulevikus" },
                { "möödas", "Möödas" },
                { "täna", "Täna" }

            };

        public bool IsPast => Due.ToLower() == "möödas";
        public bool IsFuture => Due.ToLower() == "tulevikus";
        public bool IsToday => Due.ToLower() == "täna";

    }
}
