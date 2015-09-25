
add_executable(hmacsha256_unittests hmacsha256_unittests.cpp main.c)


target_include_directories(hmacsha256_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (hmacsha256_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
