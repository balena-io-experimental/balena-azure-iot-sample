if ((CMAKE_CXX_COMPILER_ID MATCHES "Clang") OR (CMAKE_CXX_COMPILER_ID MATCHES "AppleClang"))
	message( "Clang based compiler options being used")

	set(CMAKE_C_FLAGS "-std=c99 -pedantic -Wall -w -I/usr/include")
	set(CMAKE_CXX_FLAGS "-std=c++11 -stdlib=libc++ -pedantic -Wall -w -I/usr/include")
elseif ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "GNU")
	message( "GNU compiler options being used")

	set(CMAKE_C_FLAGS "-std=c99 -pedantic -Wall -w")
	set(CMAKE_CXX_FLAGS "-std=c++11 -pedantic -Wall -w")
elseif ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "Intel")
	message( "Intel compiler options being used")

elseif ("${CMAKE_CXX_COMPILER_ID}" STREQUAL "MSVC")
	message( "Visual Studio compiler options being used")

endif()
