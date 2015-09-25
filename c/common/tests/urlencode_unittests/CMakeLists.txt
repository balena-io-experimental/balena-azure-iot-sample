
add_executable(urlencode_unittests urlencode_unittests.cpp main.c)


target_include_directories(urlencode_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (urlencode_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
