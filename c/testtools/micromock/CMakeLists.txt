set(MICROMOCK_SRC
	./src/micromockcharstararenullterminatedstrings.cpp
	./src/micromockexception.cpp
	./src/mockcallrecorder.cpp
	./src/mockmethodcallbase.cpp
	./src/mockvaluebase.cpp )

include_directories("./inc" ${TEST_INCLUDES})

set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -c -Wall -DUSE_CTEST -DDISABLE_DETOURS -Wno-unknown-pragmas -Wno-unused-function -std=c++0x -DGB_DEBUG_ALLOC -DGB_MEASURE_MEMORY_FOR_THIS")

add_library(micromock ${MICROMOCK_SRC})

