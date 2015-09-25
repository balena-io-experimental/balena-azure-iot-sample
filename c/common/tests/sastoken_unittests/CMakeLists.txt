
add_executable(sastoken_unittests sastoken_unittests.cpp main.c)


target_include_directories(sastoken_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (sastoken_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
