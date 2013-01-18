#include "FileUtil.h"

#include <fstream>
#include <boost/filesystem.hpp>

namespace bfs=boost::filesystem;


FileUtil::FileUtil(void)
{
}

FileUtil::~FileUtil(void)
{
}

void FileUtil::CopyFile (const char* src, const char* dest, const int flag)
{
	if (!PathExist(src)) throw "File Util Error : src not exist";
	if ((flag & bfs::copy_option::overwrite_if_exists) && (bfs::exists(dest)))
	{
		bfs::remove(dest);
	}
	bfs::copy_file(src,dest);
}

bool FileUtil::PathExist(const char* tpath)
{
	return bfs::exists(tpath);
}

std::string FileUtil::GetFileDirPath(const char* filePath) 
{
	if (!PathExist(filePath)) throw "File Util Error : File not exist";
	bfs::path  p(filePath);
	if (p.has_parent_path()) return p.parent_path().string();
	else return p.root_path().string();
}

bool FileUtil::IsDirExist(const char* dirPath)
{
	return (PathExist(dirPath) && bfs::is_directory(dirPath) );
}

bool FileUtil::IsFileExist(const char * filePath)
{
	if (!PathExist(filePath) ) return false;
	bfs::path pFile(filePath);
	return pFile.has_extension();
}

std::string FileUtil::GetFileName(const char * filePath)
{
	return bfs::path(filePath).stem().string();
}

bool FileUtil::CreateDir(const char* dirPath)
{
	if (IsDirExist(dirPath)) throw "Directory allready exist";
	MkDir(dirPath);
	return true;
}