#include "budgetLock.h"

#include <fstream>

bool Lock::Close()
{
    std::ofstream lock(FILE_NAME);
    lock.close();
    
    mIsLocked = true;
    return mIsLocked;
}

bool Lock::Open()
{
    remove(FILE_NAME);

    mIsLocked = false;
    return mIsLocked;
}

bool Lock::IsLocked()
{
    std::ifstream file(FILE_NAME);

    if (file.good())
        mIsLocked = true;
    else
        mIsLocked = false;
        
    file.close();
    
    return mIsLocked;
}


