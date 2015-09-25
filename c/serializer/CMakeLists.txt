
file(GLOB_RECURSE IOTHUB_SERIALIZER_SOURCES
    ${CMAKE_CURRENT_SOURCE_DIR}/inc/*.h
    ${CMAKE_CURRENT_SOURCE_DIR}/src/*.c)

list(SORT IOTHUB_SERIALIZER_SOURCES)
source_group("Source Files" FILES "${CMAKE_CURRENT_SOURCE_DIR}/src/" ${IOTHUB_SERIALIZER_SOURCES})
set_source_files_properties(IOTHUB_SERIALIZER_UNITTEST_SOURCES PROPERTIES LANGUAGE CXX)

find_package(Threads REQUIRED)

add_library(serializer STATIC ${IOTHUB_SERIALIZER_SOURCES})

target_include_directories(serializer PUBLIC "../common/inc" "inc" )

add_dependencies(serializer common)
add_dependencies(core serializer)


#add_subdirectory(samples)
#add_subdirectory(unittests)
