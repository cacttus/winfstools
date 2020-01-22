# Windows Filesystem Toolkit

This is a suite of simple filesystem tools for Microsoft Windows. 

### AutoMove

AutoMove polls an application directory for added files, then moves those files to a new directory when it sees them.  This is (was) useful for things like torrented files, if you don't want to leave your downloaded files in a shared folder.  It could also be used as a server utility, to move files that users save onto the server.

### DeltaSearch (CHM-Search)

DeltaSearch is a paralell filesystem search utility with regular expression *and CHM* support.  The tool can  open CHM files and search through their contents.  It uses paralell processing to walk through directory trees very fast.  The tool does not use indexing, as many popular search tools do, thus it is a great tool if you have limited drive space.

### DirScan

DirScan scans directories for changes and launches an executable, or file (of any kind) when it detects a filesystem change.

### Flattener

Flattener simply flattens a directory tree, placing all the files it finds into a single folder.  Place the .exe file into a directory and run this tool.  The tool will give you options on how you wish to flatten the directory.  Like most of these tools, click "run" to run the tool.  This tool is useful with DeDuper when sifting through large batches of downloaded or archived data.

### DeDuper

DeDuper removes duplicate files in a directory tree.  In conjunction with Flattener, this tool is very useful when sifting through large blocks of downloaded data.  The tool also gives you custom name-matching options. In the future, this tool should support regular expression filetypes.

### Ganker

Ganker is a tool that lets you connect to a website remotely, take all of the media off of a webpage, and poll a webpage for new media.  When new media hits the page, the Ganker application will download the media.  Ganker was written a few years ago, and may not work with modern web standards.

### Rifle 

Rifle is a timer application that runs all files, execurables (or anything else), in the specified directory.  The aplication includes a stop-watch option so that you can time when items get executed.

