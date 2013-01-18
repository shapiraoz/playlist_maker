#include "Amake.h"
#include "../Utilities/FileUtil.h"
#include <boost/algorithm/string.hpp>



Amake::Amake(void)
{
}

Amake::Amake(const char* filePath)
{
	if(!FileUtil::IsFileExist(filePath)) throw "Error:file not exist";
	m_filePath = filePath;
	m_mainDirPath = FileUtil::GetFileDirPath(m_filePath.c_str());
}


Amake::~Amake(void)
{
	m_filelist.clear();
}
//
//bool Amake::CopyAllFiles()
//{
//	if (m_filelist.size() == 0) throw "no files to copy !!!";
//	else
//	{
//		
//	}
//
//}


bool Amake::CopyAllFiles()
{
	if ( FileUtil::PathExist(m_targerFolder.c_str())) throw ERR_MSG_TRAGET_FOLDER;

	if (!FileUtil::IsDirExist(m_targerFolder.c_str())) 
	{
		m_targerFolder = m_mainDirPath + "/"+ m_targerFolder;
		MkDir(m_targerFolder.c_str());
	}
	else
	{
		std::list<std::string>::iterator it;
		for(it=m_filelist.begin();it!=m_filelist.end();it++)
		{
			FileUtil::CopyFile(it->c_str(),m_targerFolder.c_str(),REWRITE);
		}
	}
	return PASS;
}


bool Amake::CreateTragetFolder(const std::string& path)
{
	if (MkDir(path.c_str())== -1) return 0;
	m_targerFolder = path;
	return 1;
}


