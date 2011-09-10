#include "Amake.h"
#include "FileUtil.h"



Amake::Amake(void)
{
}

Amake::Amake(const char* filePath)
{
	m_filePath = filePath;
	m_mainDirPath = FileUtil::GetFileDirPath(m_filePath.c_str());

}


bool Amake::CreateTragetFolder(const string path)
{
	if (MkDir(path.c_str())== -1) return 0;
	m_targerFolder = path;
	return 1;
}

bool Amake::CopyAllFile()
{
	if ( FileUtil::PathExist(m_targerFolder.c_str())) throw ERR_MSG_TRAGET_FOLDER;


}



Amake::~Amake(void)
{
}

