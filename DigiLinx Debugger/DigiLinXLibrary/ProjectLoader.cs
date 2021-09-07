using System.Xml;

namespace DigiLinXLibrary {
    public class ProjectLoader {
        public static NetStreamsProject Load(string fileName) {
            NetStreamsProject aProject = new NetStreamsProject();
            XmlDocument aDoc = new XmlDocument();
            aDoc.Load(fileName);

            aProject.ProjectName = aDoc.SelectSingleNode("/ns_project").Attributes["projectName"].Value;
            aProject.DealerSetupVersion = aDoc.SelectSingleNode("/ns_project").Attributes["ds_build"].Value;

            LoadChildren(aDoc, aProject);
            return aProject;
        }

        private static void LoadChildren(XmlDocument aDoc, NetStreamsProject aProject) {
            aProject.Client.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/client"));
            aProject.Dealer.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/dealer"));
            aProject.SystemList.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/streamnet/systemList"));
            aProject.GUI.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/gui"));
            aProject.NonStreamNet.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/nonStreamnet"));
            aProject.Subscribers.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/subscribers"));
            aProject.Groups.LoadConfiguration(aDoc.SelectSingleNode("/ns_project/groups"));
        }
    }
}