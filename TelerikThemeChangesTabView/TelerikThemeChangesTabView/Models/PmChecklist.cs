using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace CMS.Models.Tickets
{
    public class PmChecklist 
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("workOrderNumber")]
        public string WorkOrderNumber { get; set; }

        [JsonProperty("ticketID")]
        public string TicketID { get; set; }

        [JsonProperty("unitCategory")]
        public string UnitCategory { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("installDate")]
        public string InstallDate { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("laborHrs")]
        public decimal LaborHrs { get; set; }

        [JsonProperty("partsCount")]
        public decimal PartsCount { get; set; }

        [JsonProperty("purchaseOrderCount")]
        public int PurchaseOrderCount { get; set; }

        [JsonProperty("supplyTemperature")]
        public decimal SupplyTemperature { get; set; }

        [JsonProperty("returnTemperature")]
        public decimal ReturnTemperature { get; set; }

        [JsonProperty("refrigerantType")]
        public string RefrigerantType { get; set; }

        [JsonProperty("refrigerantAmount")]
        public decimal RefrigerantAmount { get; set; }

        [JsonProperty("refrigerantRecovered")]
        public decimal RefrigerantRecovered { get; set; }

        [JsonProperty("refrigerantReclaimed")]
        public decimal RefrigerantReclaimed { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("ambientTemperature")]
        public decimal AmbientTemperature { get; set; }

        [JsonProperty("functionalpercentage")]
        public int Functionalpercentage { get; set; }

        [JsonProperty("checklist")]
        public ObservableCollection<PmChecklistItem> Checklist { get; set; }
    }
}
