using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Winkle
{
    public class UpdateInfo
    {
        public bool updateInfoRetrievalSuccessfull = false;
        public bool updateIsBeta = false;

        public bool updateAvailable = false;

        public int updateMajor = 0;
        public int updateMinor = 0;
        public int updateBuild = 0;
        public int updateRevision = 0;

        public string updateName = "";
        public string updateDescription = "";
        public System.Uri manualDownloadUrl;

        public int errorCode = 0;
        public string errorTitle = "";
        public string errorDescription = "";

    }
}
