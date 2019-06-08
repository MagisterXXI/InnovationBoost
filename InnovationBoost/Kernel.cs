using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationBoost
{
    public class Kernel
    {
        public Business[] Businesses { get; } = new Business[] {
            new Business() { Name = "ИП Агроном" },
            new Business() { Name = "ООО Фрезерные станки" },
            new Business() { Name = "ООО Рога и копыта" },
            new Business() { Name = "ОАО ДомКвартираСтрой" },
            new Business() { Name = "ООО Лучшие кровати Дона" },
            new Business() { Name = "ИП Плитка кафель и Ко" },
            new Business() { Name = "ООО АгроМашинРемонт" },
        };
    }
}
