#include "WplMake.h"
#include "./../Utilities/FileUtil.h"
#include <boost/foreach.hpp>
#include <string>
#include <iostream>
#include <fstream>


#define Base_WORKSPACE "Workspace"
#define BUFFER_CURR_SIZE 200

#define WPL_LIST_XPATH "smil.body.seq"
#define XML_BOOST_ATT_DEF "<xmlattr>.src"

WplMake::WplMake(void)
{
}

WplMake::~WplMake(void)
{
	
}

WplMake::WplMake(const char* filePath):Amake(filePath)
{
	try
	{
		pTreeLib::read_xml(filePath,m_ptree);
	}
	catch(const char * err)
	{
		std::cout << err;
	}
} 

std::string  WplMake::CreateWorkSpace()
{
	FileUtil::CreateDir(Base_WORKSPACE);
	return Base_WORKSPACE;
}

bool WplMake::ReadData()
{
	if(!m_ptree.empty())
	{
		BOOST_FOREACH(boost::property_tree::ptree::value_type const & value,m_ptree.get_child(WPL_LIST_XPATH))
		{
			std::string  filePath= value.second.get<std::string>(XML_BOOST_ATT_DEF);
			m_filelist.push_back(filePath);
		}
	}
	return PASS;
}


std::list<std::string>&  WplMake::GetFilesList()
{
	return m_filelist;
}