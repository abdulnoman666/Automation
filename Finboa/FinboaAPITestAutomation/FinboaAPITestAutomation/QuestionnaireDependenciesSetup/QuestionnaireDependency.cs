using System;
using System.Collections.Generic;
using System.Text;

namespace FinboaAPITestAutomation.QuestionnaireDependenciesSetup
{
    internal class QuestionnaireDependency
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string WorkFlowName { get; set; }
        public int Order { get; set; }
    }
}
