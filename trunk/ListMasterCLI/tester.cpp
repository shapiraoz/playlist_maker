#include "Utilities/FileUtil.h"
#include <boost/exception/exception.hpp>
#include <boost/exception/all.hpp> 
#include <exception>
#include "Core/WplMake.h"
#include <conio.h>

#include <list>

void main()
{
	//FileUtil fu;
	
	try
	{
	    WplMake am("D:/My_Playlists/oldGrove_1.wpl");
		am.ReadData();
		std::list<std::string> l=  am.GetFilesList();
		std::list<std::string>::iterator it;
		std::cout <<"list is :" <<std::endl;
		for(it=l.begin();it!=l.end();it++)
		{
			std::cout << *it <<std::endl;
		}

	//am.CreateTragetFolder("d:\\1\\2");
		getch(); 
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