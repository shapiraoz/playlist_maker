using System;
using System.Collections.Generic;
using System.Text;
using CoreListMaker;

namespace ListMusicMakerCLI
{
    class PlayListMakerCLI
    {
        const string ERR_MSG_PATH_NOT_FILED = "playlist file not empty";

        public PlayListMakerCLI(string  filePath,string newFolderName)
        {
            m_filePath = filePath;
            m_newFolderName = newFolderName;
        }

        public void GO()
        {
            if (m_filePath.Length == 0) throw (new Exception(ERR_MSG_PATH_NOT_FILED));
            else
            {
                
            }

        }



        private string m_filePath;
        private string m_newFolderName;
    }
}
