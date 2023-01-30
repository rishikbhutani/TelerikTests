using CMS.Models.Tickets;
using FreshMvvm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView.ViewModels
{
    public class Items
    {
        public string Name { get; set; }
    }
    public class AboutViewModel : FreshBasePageModel
    {
        private List<Items> _manufacturers;
        public ObservableCollection<PmChecklistItem> _checkListData;
        private Double _text;

        public AboutViewModel()
        {
            //Title = "About";
            Text = 0.01;
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            SearchItems = new List<Items>();
            this.SubHeaderValues = new ObservableCollection<string>();
            CheckListData = new ObservableCollection<PmChecklistItem>();
            GetCheckList();
            SearchItems.Add(new Items() { Name = "Name 1" });
            SearchItems.Add(new Items() { Name = "Name 2" });
            SearchItems.Add(new Items() { Name = "Name 3" });
            SearchItems.Add(new Items() { Name = "Name 4" });
        }
        public ObservableCollection<string> SubHeaderValues { get; set; }
        public List<Items> SearchItems
        {
            get
            {
                return _manufacturers;
            }
            set
            {
                _manufacturers = value;
                RaisePropertyChanged(nameof(SearchItems));
            }
        }
        public ObservableCollection<PmChecklistItem> CheckListData
        {
            get
            {
                return _checkListData;
            }
            set
            {
                _checkListData = value;
                RaisePropertyChanged(nameof(CheckListData));
            }
        }
        public double Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                RaisePropertyChanged(nameof(Text));
            }
        }

        public RadListView BeltList;
        public ICommand OpenWebCommand { get; }

        public ICommand OpenBeltsPopUpCommand => new Command<RadButton>((RadButton radButton) =>
        {
            CheckListData.Add( new PmChecklistItem { Description = "temp", Category = "ALL", Value = -1, BoldStyle = true });
            BeltList.HeightRequest = CheckListData != null ? CheckListData.Count * BeltList.MinimumHeightRequest : 0;
        });
        private async void GetCheckList()
        {
            string a = "{\r\n    \"id\": \"5f4b0f5e-01f7-4ef2-ae72-aefcfb2e7b96\",\r\n    \"workOrderNumber\": \"   2386971\",\r\n    \"ticketID\": \"4f632cba-2566-4cc8-9cad-30ebc98f2cae\",\r\n    \"unitCategory\": \"AC\",\r\n    \"name\": \"AC 9AC\",\r\n    \"description\": \"AIR CURTAIN\",\r\n    \"make\": \"AC PRO\",\r\n    \"model\": \"1\",\r\n    \"serialNumber\": \"12TEST\",\r\n    \"installDate\": \"01/01/2022 00:00:00\",\r\n    \"age\": 0,\r\n    \"notes\": \"hello test\",\r\n    \"laborHrs\": 7.00,\r\n    \"partsCount\": 163.00,\r\n    \"purchaseOrderCount\": 0,\r\n    \"supplyTemperature\": 0.00,\r\n    \"returnTemperature\": 0.00,\r\n    \"refrigerantAmount\": 1.00,\r\n    \"refrigerantRecovered\": 11.00,\r\n    \"refrigerantReclaimed\": 12.00,\r\n    \"complete\": false,\r\n    \"ambientTemperature\": 0.00,\r\n    \"checklist\": [\r\n        {\r\n            \"id\": \"1c5d7ab0-b8f2-419d-b158-98de9ae7643e\",\r\n            \"categoryId\": \"5b2d5c5a-b41c-4456-a375-f6f505debf55\",\r\n            \"category\": \"CABINET\",\r\n            \"description\": \"Cabinet / Paint\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"b71b9df7-b003-4eb1-96ef-41318ed48ea3\",\r\n            \"categoryId\": \"5b2d5c5a-b41c-4456-a375-f6f505debf55\",\r\n            \"category\": \"CABINET\",\r\n            \"description\": \"Outdoor Air Screen\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"d56ee267-e1e9-462e-aa7d-c69054295892\",\r\n            \"categoryId\": \"5b2d5c5a-b41c-4456-a375-f6f505debf55\",\r\n            \"category\": \"CABINET\",\r\n            \"description\": \"Panels / Insulation\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"6303e5ff-ceca-4e4f-80d1-fee3ef16d4bf\",\r\n            \"categoryId\": \"fbb649ba-1641-46a4-a177-77d798318a86\",\r\n            \"category\": \"ROOF/SERVICE AREA\",\r\n            \"description\": \"Curb & Stands\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"e7354378-02fc-40f7-9afa-9b6598a88fbf\",\r\n            \"categoryId\": \"fbb649ba-1641-46a4-a177-77d798318a86\",\r\n            \"category\": \"ROOF/SERVICE AREA\",\r\n            \"description\": \"Condensate Drain\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"f01b7594-b5a1-4c36-b233-93ab2768e9c4\",\r\n            \"categoryId\": \"fbb649ba-1641-46a4-a177-77d798318a86\",\r\n            \"category\": \"ROOF/SERVICE AREA\",\r\n            \"description\": \"ACR Piping / Insulation\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"802d9904-4969-4dae-9afc-e6a8c4b652f3\",\r\n            \"categoryId\": \"fbb649ba-1641-46a4-a177-77d798318a86\",\r\n            \"category\": \"ROOF/SERVICE AREA\",\r\n            \"description\": \"Debris / Trash\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"d2935e65-f40b-4bf7-b9a9-f7a39340e472\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Filters\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"7543a04c-450c-469a-862d-cf489bc4bc42\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Coil Condition\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"496489b9-6eed-47a3-99b6-bced9e346bc3\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Drain Pan / Lines\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"5a983750-8af5-4688-87f8-39826bf8db0c\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Belts\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"bb8e8ea7-dbb9-4e06-b2a1-b9eddd066fea\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Pulleys\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"cd6ec843-8cf0-40f3-abc7-c299fa602c85\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Blower Wheel\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"020629f2-6d5a-46c6-ab05-965f66d37f41\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Bearing / Brackets\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"175e3783-147b-4e5c-b008-9e213277b250\",\r\n            \"categoryId\": \"c63b7eef-4190-4982-87ed-08825dcfe29c\",\r\n            \"category\": \"FAN AREA\",\r\n            \"description\": \"Motor\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"5d63922e-e2e1-4fb6-b6c1-95f0e36abb3a\",\r\n            \"categoryId\": \"f46fd3e9-af4c-4ff6-bfbf-4770f85b39e9\",\r\n            \"category\": \"ELECTRICAL\",\r\n            \"description\": \"Wiring\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"ec695b1a-6e40-443d-abe0-8d68620d78f3\",\r\n            \"categoryId\": \"f46fd3e9-af4c-4ff6-bfbf-4770f85b39e9\",\r\n            \"category\": \"ELECTRICAL\",\r\n            \"description\": \"T-Stat / Automation\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"5be9269e-f293-4f9c-8735-91de5422c2d3\",\r\n            \"categoryId\": \"f46fd3e9-af4c-4ff6-bfbf-4770f85b39e9\",\r\n            \"category\": \"ELECTRICAL\",\r\n            \"description\": \"Operational Controls\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"ef54463d-ea33-47c5-b80c-50f062ec4b52\",\r\n            \"categoryId\": \"f46fd3e9-af4c-4ff6-bfbf-4770f85b39e9\",\r\n            \"category\": \"ELECTRICAL\",\r\n            \"description\": \"Safety Controls\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"444af52b-4168-4aeb-9f64-be2917a7e576\",\r\n            \"categoryId\": \"f46fd3e9-af4c-4ff6-bfbf-4770f85b39e9\",\r\n            \"category\": \"ELECTRICAL\",\r\n            \"description\": \"Disconnect / Fusers\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"7731c5b8-a7a4-4ce9-97ed-80d54d8a255a\",\r\n            \"categoryId\": \"f7c5e653-1a09-4ce3-9cf9-f859e67931aa\",\r\n            \"category\": \"CONDENSING\",\r\n            \"description\": \"Refrigerant Charge\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"4852ebba-2727-426a-9423-87dd93313e2a\",\r\n            \"categoryId\": \"f7c5e653-1a09-4ce3-9cf9-f859e67931aa\",\r\n            \"category\": \"CONDENSING\",\r\n            \"description\": \"Coil Condition\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"b98e769a-bc7f-49f2-a9c7-2e2fff86e1b5\",\r\n            \"categoryId\": \"f7c5e653-1a09-4ce3-9cf9-f859e67931aa\",\r\n            \"category\": \"CONDENSING\",\r\n            \"description\": \"Visual Leak Check\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"4c59860f-df33-433b-b734-f4df4adecf1c\",\r\n            \"categoryId\": \"f7c5e653-1a09-4ce3-9cf9-f859e67931aa\",\r\n            \"category\": \"CONDENSING\",\r\n            \"description\": \"Drier Condition\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"50e571fc-971b-4cf6-a76a-afead4e7ca08\",\r\n            \"categoryId\": \"f7c5e653-1a09-4ce3-9cf9-f859e67931aa\",\r\n            \"category\": \"CONDENSING\",\r\n            \"description\": \"Compressor\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"0d9804c7-4ad2-43a8-ab8b-1d55cee8161c\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Burners / Heat Exchanger\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"01486c9c-6004-41a9-bfcd-c5f0df97b6cf\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Electric Heaters\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"cce0090d-be77-4295-965d-535d9230342a\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Ignition Control\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"6e39e467-a18a-4a8b-a429-582d55cf01d3\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Safety Controls\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"94f15796-43bf-4599-aca3-3fb2756e2046\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Oper. Controls / Valves\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        },\r\n        {\r\n            \"id\": \"c1955839-28d6-495f-827c-aa3ed89c843e\",\r\n            \"categoryId\": \"00243b31-b39e-45d2-a334-e37c1d4e9392\",\r\n            \"category\": \"HEATING\",\r\n            \"description\": \"Gas Lines\",\r\n            \"fieldDefault\": 0,\r\n            \"value\": 0\r\n        }\r\n    ]\r\n}";
            PmChecklist checkListDataCopy = JsonConvert.DeserializeObject<PmChecklist>(a);
            if (checkListDataCopy != null)
            {
                ObservableCollection<PmChecklistItem> temp = new ObservableCollection<PmChecklistItem>();
                for (var i = 1; i < checkListDataCopy.Checklist.Count; i++)
                {
                    //checkListDataCopy.Checklist[i].Value = -1;
                    //if (checkListDataCopy.Checklist[i].Category != checkListDataCopy.Checklist[i - 1].Category)
                    //{
                    //    SubHeaderValues.Add(checkListDataCopy.Checklist[i].Category);
                    //    checkListDataCopy.Checklist.Insert(i, new PmChecklistItem
                    //    {
                    //        Description = checkListDataCopy.Checklist[i].Category,
                    //        Category = checkListDataCopy.Checklist[i].Category,
                    //        Value = -1,
                    //        BoldStyle = true
                    //    });
                    //    i++;
                    //}
                    temp.Add(checkListDataCopy.Checklist[i]);
                    if (temp.Count == 4)
                    {
                        break;
                    }
                }

                CheckListData = temp;
            }

        }
        internal void UpdateSegmentValues(RadSegmentedControl segment, int newValue)
        {
            ObservableCollection<PmChecklistItem> checkListDataCopy = CheckListData;
            if (segment.ClassId == "ALL")
            {
                for (int i = 0; i < checkListDataCopy.Count; i++)
                {
                    checkListDataCopy[i].Value = newValue;
                }
            }
            else if (SubHeaderValues.Contains(segment.ClassId))
            {
                for (int i = 0; i < checkListDataCopy.Count; i++)
                {
                    if (checkListDataCopy[i].Category == segment.ClassId)
                    {
                        checkListDataCopy[i].Value = newValue;
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkListDataCopy.Count; i++)
                {
                    if (checkListDataCopy[i].Description == segment.ClassId)
                    {
                        checkListDataCopy[i].Value = newValue;
                    }
                }
            }
            CheckListData = checkListDataCopy;
        }
    }
}