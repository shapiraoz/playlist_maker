#include "WplMake.h"
#include ".\..\Utilities\FileUtil.h"
#include <string>


WplMake::WplMake(void)
{
}


WplMake::~WplMake(void)
{
	
}


WplMake::WplMake(const char* filePath):Amake(filePath)
{
	
	string fPath(filePath);
	pTreeLib::read_xml(fPath,m_ptree);
	
	//BOOST_FOREACH(m_ptree::


	
} 

bool WplMake::ReadData()
{
	

	return PASS;
}