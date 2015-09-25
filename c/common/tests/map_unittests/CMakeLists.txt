
add_executable(map_unittests map_unittests.cpp main.c)


target_include_directories(map_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (map_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
