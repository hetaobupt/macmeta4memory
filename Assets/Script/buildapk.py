import os
import sys
import time
 
unity_exe = '/Applications/Unity/Hub/Editor/2021.3.6f1c1/Unity.app/Contents/MacOS/Unity'
project_path = '/Users/taoht/Desktop/Unity/macmeta4memory'
run_times = 10

log_file = os.getcwd() + '/unity_log.log'
static_func = 'BuildTools.BuildApk'
 
 
def clear_log():
    if os.path.exists(log_file):
        os.remove(log_file)
 
def call_unity_static_func(func):
    time.sleep(1)
    clear_log()
    time.sleep(1)
    cmd = ' %s -quit -batchmode -projectPath %s -logFile %s -executeMethod %s --productName:%s --version:%s'%(unity_exe,project_path,log_file,func, "macmeta4memory", "0.1.0")
    print('run cmd:  ' + cmd)
    os.system(cmd)
 
    
 
 
if __name__ == '__main__':
    while run_times > 0:
        call_unity_static_func(static_func)
        print('done')
        time.sleep(10)
        run_times -= 1
