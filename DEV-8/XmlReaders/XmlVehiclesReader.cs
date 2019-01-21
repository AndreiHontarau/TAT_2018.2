using System.Collections.Generic;
using System.Xml;
using DEV_5.Products;

namespace DEV_5.XmlReaders
{
    partial class XmlVehiclesReader
    {
        private static XmlVehiclesReader reader;

        /// <summary>
        /// Creates an empty XmlVehiclesReader object
        /// </summary>
        private XmlVehiclesReader() { }

        /// <summary>
        /// Returns XmlVehiclesReader singleton object
        /// </summary>
        /// <returns>An instance of XmlVehiclesReader</returns>
        public static XmlVehiclesReader GetInstance()
        {
            if (reader == null)
            {
                reader = new XmlVehiclesReader();
            }

            return reader;
        }

        public List<Vehicle> ReadVehicles(string xmlFilePath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(xmlFilePath);
            List<Vehicle> vehiclesList = new List<Vehicle>();
            XmlElement documentRoot = document.DocumentElement;

            string productType = documentRoot.Name.ToString();
            var factory = FactoriesDictionary[productType];

            List<string> productInfo = new List<string>();
            Vehicle vehicle;

            foreach (XmlNode node in documentRoot.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "brand")
                    {
                        productInfo.Add(childNode.InnerText);
                    }

                    if (childNode.Name == "model")
                    {
                        productInfo.Add(childNode.InnerText);
                    }

                    if (childNode.Name == "price")
                    {
                        productInfo.Add(childNode.InnerText);
                    }

                    if (childNode.Name == "amount")
                    {
                        productInfo.Add(childNode.InnerText);
                    }

                }

                factory.Create(out vehicle, productInfo.ToArray());
                vehiclesList.Add(vehicle);
                productInfo.Clear();
            }

            return vehiclesList;
        }
    }
}
