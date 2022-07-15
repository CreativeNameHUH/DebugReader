#ifndef _WALMART_LOCK_H_
#define _WALMART_LOCK_H_

#define FILE_NAME "lock.lock"

class Lock
{
public:
    static bool Close();
    static bool Open();
    static bool IsLocked();

private:
    static bool mIsLocked;
};

#endif // _WALMART_LOCK_H_
