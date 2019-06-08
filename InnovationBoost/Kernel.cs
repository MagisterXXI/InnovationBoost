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
            new Business() { Name = "ООО \"Агропромышенный холдинг\"" },
            new Business() { Name = "ИП Иванченко" },
            new Business() { Name = "ООО Рога и копыта" },
            new Business() { Name = "ОАО ДомКвартираСтрой" },
            new Business() { Name = "ООО Лучшие кровати Дона" },
            new Business() { Name = "УП Плитка кафель и Ко" },
            new Business() { Name = "ООО АгроМашинРемонт" },
        };

        public Problem[] Problems { get; } = new Problem[] {
            new Problem() {Name = "Разработка интеллектуальной системы орашения полей" },
            new Problem() {Name = "Разработать подшипник фрезерного станка с коэф. трения ниже 4" },
        };
    }
}
