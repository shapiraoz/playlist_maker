#ifndef UTIL_H
#define UTIL_H
#include <iostream>

#ifdef WINDOWS 
	#include <direct.h>
	#define MkDir _mkdir
	#define GetCurrentDir _getcwd
#else
	//#include <unistd.h>
	#define MkDir mkdir
	#define GetCurrentDir getcwd
#endif
#define FU_REWRITE 1

using namespace std;
#pragma once


class FileUtil
{

public:

	FileUtil(void);
	~FileUtil(void);

	void static CopyFile (const char* src, const char* dest, const int flag);
	bool static PathExist(const char* path);
	string static GetFileDirPath(const char* filePath);
	bool IsDirExist(const char* dirPath);
};


#endif