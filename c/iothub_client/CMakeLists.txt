
file(GLOB_RECURSE IOTHUB_CLIENT_SOURCES
    ${CMAKE_CURRENT_SOURCE_DIR}/inc/*.h
    ${CMAKE_CURRENT_SOURCE_DIR}/src/*.c)

list(SORT IOTHUB_CLIENT_SOURCES)
source_group("Source Files" FILES "${CMAKE_CURRENT_SOURCE_DIR}/src/" ${IOTHUB_CLIENT_SOURCES})
set_source_files_properties(IOTHUB_CLIENT_UNITTEST_SOURCES PROPERTIES LANGUAGE CXX)

find_package(Threads REQUIRED)

add_library(iothub_client STATIC ${IOTHUB_CLIENT_SOURCES})
target_link_libraries (iothub_client ${CMAKE_THREAD_LIBS_INIT})
target_include_directories(iothub_client PUBLIC "../common/inc" "inc" "${QPID_PROTON_INCLUDE_DIR}" )

add_dependencies(iothub_client common)
add_dependencies(core iothub_client)


#add_subdirectory(samples)
#add_subdirectory(unittests)
