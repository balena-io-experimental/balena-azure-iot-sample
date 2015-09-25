file(GLOB_RECURSE CTEST_SRC
		${CMAKE_CURRENT_SOURCE_DIR}/src/*.c )	

include_directories(${CTEST_INC})
add_library(ctest ${CTEST_SRC} ${CTEST_INC})