#ifndef AMAKE_H
#define AMAKE_H

#pragma once

#include <list>
#include <iostream>
#include <string>

#define REGEX_FILE_NAME_FORMAT "[A-Za-z0-9 -. à-ú ()]+.[flacMmPp3wa]$"
#define ERR_MSG_TRAGET_FOLDER "Error: traget folder is not konw" 
#define CANT_COPY_MSG  "error can't copy file :"


#define PASS 1
#define FAIL 0


class Amake
{
	
public:
		Amake(void);
		Amake(const char* filePath);
		~Amake(void);
		virtual bool ReadData() = 0 ;
		virtual bool CreateTragetFolder(const std::string& path);
		bool CopyAllFiles();
	

protected:
	
	std::list<std::string> m_filelist; 
	int m_itemCnt;
	std::string m_targerFolder;   
	std::string m_filePath;
	std::string m_srcFilePath;
	std::string m_mainDirPath;


};

#endif
