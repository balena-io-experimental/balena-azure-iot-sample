#
# IoT Hub Common lib
#

IF(MSVC)
	
ELSE() # TODO: Need to make all platform checks here, adding proper files per plaform
	file(GLOB_RECURSE IOTHUB_COMMON_SOURCES
		${CMAKE_CURRENT_SOURCE_DIR}/inc/*.h
		${CMAKE_CURRENT_SOURCE_DIR}/src/*.c
		$(CMAKE_CURRENT_SOURCE_DIR)/adapters/agenttime.c
		$(CMAKE_CURRENT_SOURCE_DIR)/adapters/threadapi_pthreads.c
		$(CMAKE_CURRENT_SOURCE_DIR)/adapters/lock_pthreads.c
		$(CMAKE_CURRENT_SOURCE_DIR)/adapters/httpapi_curl.c
	    $(CMAKE_CURRENT_SOURCE_DIR)/adapters/mqttapi_paho.c)
ENDIF()

list(SORT IOTHUB_COMMON_SOURCES)

set(COMMON_SRC ${CMAKE_CURRENT_SOURCE_DIR}/src)
include_directories(${CMAKE_CURRENT_SOURCE_DIR}/inc)

find_package(Threads REQUIRED)

add_library(common STATIC ${IOTHUB_COMMON_SOURCES})
target_link_libraries (common ${CMAKE_THREAD_LIBS_INIT})
add_dependencies(core common)

add_subdirectory(tests)

