#include "Utilities\FileUtil.h"
#include <boost/exception/exception.hpp>
#include <boost/exception/all.hpp> 
#include <exception>
#include "Core\WplMake.h"
#include <conio.h>

void main()
{
	//FileUtil fu;
	
	try
	{
		WplMake am("D:\\My_Playlists\\s_Full.wpl");
		FileUtil::CopyFile("d:\\2.txt","d:\\1\\2.txt",1);
	//am.CreateTragetFolder("d:\\1\\2");
	}
	catch (boost::exception &e)
	{
		std::cout << boost::diagnostic_information(e);
		getch();
	}
	catch(char * err)
	{
		std::cout << err ;
	}
}