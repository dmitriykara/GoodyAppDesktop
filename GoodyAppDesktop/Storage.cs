using System.Collections.Generic;

namespace GoodyAppDesktop
{
    public static class Storage
    {
        public static string CurrentDistrict { get; set; } = "Басманный район";
        public static string Name { get; set; }
        public static List<string> Districts { get; set; } =
            new List<string>(){ "Басманный район", "Район Выхино-Жулебино",
                "Нагорный район", "Район Нагатинский затон" };
    }

}
