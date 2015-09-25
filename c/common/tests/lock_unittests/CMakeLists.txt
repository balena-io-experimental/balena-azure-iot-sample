
add_executable(lock_unittests lock_unittests.cpp main.c ../../adapters/lock_pthreads.c )


target_include_directories(lock_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (lock_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
