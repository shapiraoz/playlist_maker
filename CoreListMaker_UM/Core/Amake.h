#ifndef AMAKE_H
#define AMAKE_H

#pragma once

#include <list>
#include <iostream>
#include <string>

#define REGEX_FILE_NAME_FORMAT "[A-Za-z0-9 -. �-� ()]+.[flacMmPp3wa]$"
#define ERR_MSG_TRAGET_FOLDER "Error: traget folder is not konw" 

using namespace std;
class Amake
{
	
public:
		Amake(void);
		Amake(const char* filePath);
		~Amake(void);
		bool CreateTragetFolder(const string path);
		bool CopyAllFile();

protected:
	list<string> m_filelist; 
	int m_itemCnt;
	string m_targerFolder;   
	string m_filePath;
	string m_srcFilePath;
	string m_mainDirPath;


};

#endif
