#include "FileUtil.h"
#include "Amake.h"

void main()
{
	//FileUtil fu;
	Amake am("d:\\1\\1.txt");
	try
	{

	FileUtil::CopyFile("d:\\2.txt","d:\\1\\2.txt",1);
	am.CreateTragetFolder("d:\\1\\2");
	}
	catch(char * err)
	{
		std::cout << err ;
	}
}