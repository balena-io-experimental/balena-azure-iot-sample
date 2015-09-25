
add_executable(vector_unittests vector_unittests.cpp main.c)


target_include_directories(vector_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (vector_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
