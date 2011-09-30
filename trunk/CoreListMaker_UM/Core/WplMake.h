#ifndef WPLMAKE_H
#define WPLMAKE_H

#pragma once
#include "amake.h"

#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/xml_parser.hpp>

namespace pTreeLib=boost::property_tree;

class WplMake :	public Amake
{
public:
	WplMake(void);
	WplMake(const char* filePath);
	~WplMake(void);
	
	virtual bool ReadData(); 
private:
	pTreeLib::ptree m_ptree ; 
};


#endif
